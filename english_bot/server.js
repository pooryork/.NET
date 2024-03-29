const express = require('express');
const ejs = require('ejs');
let bodyParser = require("body-parser");
let urlencodedParser = bodyParser.urlencoded({
    extended: false
});
const fileUpload = require('express-fileupload');
let mysql = require('mysql');
let random = require('random');

var pool = mysql.createPool({
    connectionLimit: 10,
    host: 'a0369141.xsph.ru',
    user: 'a0369141_anglichanin',
    password: '37153715',
    database: 'a0369141_anglichanin'
});

/* 
Имя базы данных: a0369141_anglichanin
Адрес хоста: localhost
Пользователь: a0369141_anglichanin
Пароль: 37153715
*/

let app = express();

app.set('view engine', 'ejs');
app.use('/public', express.static('public'));
app.use(fileUpload());

let pictures;

function reshake(array) {

    let returnObj = {};

    let usedNumbers = [];

    for (let i in array) {

        let num = random.int(min = 0, max = array.length);

        while (usedNumbers.indexOf(num) != -1) {

            num = random.int(min = 0, max = array.length);

        }

        returnObj[i] = array[i];

        console.log(array[i]);
        console.log(returnObj[i]);

        usedNumbers.push(num);

    }

    return returnObj;
}

app.get('/', (req, res) => {
    res.writeHead(302, {
        'Location': '/main'
    });
    res.end();
});

app.get('/main', function (req, res) {
    res.render('main', {
        typeAuth: 'noLogin',
        type_content: 'mainInfo'
    });
});

app.get('/learn', function (req, res) {

    let sql = 'SELECT topic FROM pictures';
    pool.query(sql, [], function (req, res1) {

        let topics = [];
        console.log(res1);
        for (i in res1) {
            if (topics.indexOf(res1[i].topic) == -1) {
                topics.push(res1[i].topic);
            }
        }

        console.log(topics);

        res.render('main', {
            typeAuth: 'noLogin',
            type_content: 'choose',
            type_form: 'learn',
            data: topics
        });
    });
});

app.post('/learn', urlencodedParser, function (req, res) {

    let data = req.body;

    if (data.learn == '') {
        console.log(data);
        let sql = 'SELECT * FROM pictures WHERE topic = ? LIMIT ' + data.numOfWords;
        pool.query(sql, [data.topic], function (req, res1) {

            console.log(res1);

            res.render('main', {
                typeAuth: 'noLogin',
                type_content: 'learn',
                data: res1
            });

        });
    }

});

app.get('/about', function (req, res) {
    res.render('main', {
        typeAuth: 'noLogin',
        type_content: 'about'
    });
});

app.get('/choose_train', function (req, res) {

    let sql = 'SELECT topic FROM pictures';
    pool.query(sql, [], function (req, res1) {

        let topics = [];
        console.log(res1);
        for (i in res1) {
            if (topics.indexOf(res1[i].topic) == -1) {
                topics.push(res1[i].topic);
            }
        }

        console.log(topics);

        res.render('main', {
            typeAuth: 'noLogin',
            type_content: 'choose',
            type_form: 'choose_train',
            data: topics
        });
    });
});

app.post('/choose_train', urlencodedParser, function (req, res) {

    let data = req.body;
    console.log(data);

    let sql = 'SELECT * FROM pictures WHERE topic = ? LIMIT ' + data.numOfWords;

    try {

        pool.query(sql, [data.topic], function (req, res1) {

            console.log(res1);
            pictures = res1;
            cur_train = res1;

            res.render('main', {
                typeAuth: 'noLogin',
                type_content: 'train',
                data: pictures
            });

        });
    } catch (e) {
        console.log('Ууупс ...');
        console.log(e);
    }
});

app.post('/train', urlencodedParser, function (req, res) {

    let data = req.body;
    console.log(data);

    let incorrectAnswers = [];
    let incorrectAnswersData = [];
    let correctAnswers = 0;

    for (let key in data) {

        console.log(key.toLowerCase() + ' - ' + data[key]);

        if (key.toLowerCase() == data[key].toLowerCase()) {
            correctAnswers++;
        } else {
            incorrectAnswers.push(key.toLowerCase());
        }
    }

    for (let i in pictures) {

        console.log(incorrectAnswers);
        console.log(incorrectAnswers.indexOf(pictures[i].word) !== -1);
        console.log(pictures[i].word);
        if (incorrectAnswers.indexOf(pictures[i].word.toLowerCase()) !== -1) {
            incorrectAnswersData.push(pictures[i]);
        }
    }

    console.log(incorrectAnswersData);

    console.log(correctAnswers);

    if (correctAnswers == pictures.length) {

        res.render('main', {
            typeAuth: 'noLogin',
            type_content: 'results',
            msg: 'Всё правильно!',
            data: incorrectAnswersData,
            correctAnswers: correctAnswers
        });
    } else {
        res.render('main', {
            typeAuth: 'noLogin',
            type_content: 'results',
            msg: 'Повторите ещё раз эти слова!',
            data: incorrectAnswersData,
            correctAnswers: correctAnswers
        });
    }

});

app.get('/add', function (req, res) {
    res.render('main', {
        typeAuth: 'admin',
        type_content: 'add',
        msg: 'nomsg'
    });
});

app.post('/add', urlencodedParser, function (req, res) {

    let data = req.body;
    console.log(data);

    let isUnique = true;

    let sql = 'SELECT * FROM pictures WHERE topic = ? AND word = ?';
    pool.query(sql, [data.topic, data.word], function (req1, res1) {

        try {

            console.log(res1);
            console.log(res1.length);
            if (res1.length == 0) {
                let picture_ref = '/public/img/' + data.word.toLowerCase() + '.jpg';

                // The name of the input field (i.e. "sampleFile") is used to retrieve the uploaded file
                console.log(req.files);
                // The name of the input field (i.e. "sampleFile") is used to retrieve the uploaded file
                var startup_image = req.files.foo;
                // Use the mv() method to place the file somewhere on your server
                startup_image.mv(__dirname + '/public/img/' + data.word.toLowerCase() + '.jpg', function (err) {
                    if (err) {
                        console.log(err);
                    } else {
                        console.log("uploaded");
                    }
                });

                let sql_insert = "INSERT INTO pictures (topic, word, picture_ref) VALUES (?, ?, ?)";
                pool.query(sql_insert, [data.topic, data.word, picture_ref], function (req2, res2) {});

                console.log(data);
                let text = 'Слово "' + data.word + '"добавлено в категорию "' + data.topic + '"';

                res.render('main', {
                    typeAuth: 'admin',
                    type_content: 'add',
                    msg: text
                });
            } else {
                res.render('main', {
                    typeAuth: 'admin',
                    type_content: 'add',
                    msg: 'Такое слово уже существует в такой категории!'
                });
            }

        } catch {
            res.render('main', {
                typeAuth: 'admin',
                type_content: 'add',
                msg: 'Что-то пошло не так ;('
            });
        }

    });

});

app.get('/delete', function (req, res) {

    let sql = 'SELECT * FROM pictures';

    pool.query(sql, [], function (req, res1) {

        console.log(res1);
        pictures = res1;
        cur_train = res1;

        res.render('main', {
            typeAuth: 'admin',
            type_content: 'delete',
            data: pictures,
            msg: 'nomsg'
        });

    });
});

app.post('/delete', urlencodedParser, function (req, res) {

    let data = req.body;

    for (i in data) {

        console.log(i);

        let sql = "DELETE FROM pictures WHERE id = ?";

        pool.query(sql, [i], function (req, res1) {

            console.log(res1);

            res.redirect('/delete');

        });
    }
});

app.get('/login', function (req, res) {

res.render('main', {
    typeAuth: '',
    type_content: 'login',
    data: pictures,
    msg: 'nomsg'
});

});

app.post('/login', urlencodedParser, function (req, res) {

    let data = req.body;

    console.log(data);

    //если поля пусты
    if (data.login == '' || data.password == '') {
        // res.render('mainAuth', {
        //     type: 'login'
        // });
    }
    //если поля не пусты
    else {
        //запрос для авторизации
        let sql = 'SELECT * FROM clients WHERE login = ?';
        pool.query(sql, [data.login], function (req, res1) {

            try {
                console.log(res1[0]);

                if (res1[0].login == data.login && res1[0].passwordHash == data.password) {
                    console.log('Красава!');
                    res.redirect('/add');
                } else {
                    console.log('Ебать ты лох!');
                    res.redirect('/login');
                }
            } catch {
                console.log('Ебать ты лох!');
                res.redirect('/login');
            }
        });
    }

});

app.listen(3000);