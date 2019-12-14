const express = require('express');
const ejs = require('ejs');
let bodyParser = require("body-parser");
let urlencodedParser = bodyParser.urlencoded({
    extended: false
});
const fileUpload = require('express-fileupload');
let mysql = require('mysql');

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
let cur_train;

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
    let sql = 'SELECT * FROM pictures WHERE topic = ?';

    try {

        pool.query(sql, ['animals'], function (req, res1) {

            console.log(res1);
            pictures = res1;

            res.render('main', {
                typeAuth: 'noLogin',
                type_content: 'learn',
                data: res1
            });

            // for (i in res1) {
            //     //console.log(i);
            //     words.push(res1[i].word);
            //     topics.push(res1[i].topic);
            //     refs.push(res1[i].picture_ref);
            //     // console.log(res[i].word);
            //     // console.log(res[i].topic);
            //     // console.log(res[i].picture_ref);
            // }
            // console.log(words);
            // console.log(topics);
            // console.log(refs);

        });
    } catch (e) {
        console.log('Ууупс ...');
        console.log(e);
    }
});

app.get('/about', function (req, res) {
    res.render('main', {
        typeAuth: 'noLogin',
        type_content: 'about'
    });
});

app.get('/train', function (req, res) {
    let sql = 'SELECT * FROM pictures WHERE topic = ?';

    try {

        pool.query(sql, ['animals'], function (req, res1) {

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

app.get('/admin', function (req, res) {
    res.render('main', {
        typeAuth: 'noLogin',
        type_content: 'admin',
        msg: 'nomsg'
    });
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

    res.render('main', {
        typeAuth: 'noLogin',
        type_content: 'results',
        data: incorrectAnswersData,
        correctAnswers: correctAnswers
    });

});

app.post('/admin', urlencodedParser, function (req, res) {

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
                    typeAuth: 'noLogin',
                    type_content: 'admin',
                    msg: text
                });
            } else {
                res.render('main', {
                    typeAuth: 'noLogin',
                    type_content: 'admin',
                    msg: 'Такое слово уже существует в такой категории!'
                });
            }

        } catch {
            res.render('main', {
                typeAuth: 'noLogin',
                type_content: 'admin',
                msg: 'Что-то пошло не так ;('
            });
        }

    });

});

app.post('/register', urlencodedParser, function (req, res) {

    let data = req.body;

    console.log(data.login);

});

app.listen(3000);