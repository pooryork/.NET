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

function orderByRand() {

}

/* 
Имя базы данных: a0369141_anglichanin
Адрес хоста: localhost
Пользователь: a0369141_anglichanin
Пароль: 37153715
*/

let app = express();

app.set('view engine', 'ejs');
app.use('/public', express.static('public'));
app.use(fileUpload({
    tempFileDir: '/public/img'
}));
//app.use(express.static(__dirname + "/public"));
//app.use(__dirname + './static', express.static('static'));

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
            res_send = res1;

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
            res_send = res1;

            res.render('main', {
                typeAuth: 'noLogin',
                type_content: 'train',
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

app.get('/admin', function (req, res) {
    res.render('main', {
        typeAuth: 'noLogin',
        type_content: 'admin'
    });
});

app.post('/admin', urlencodedParser, function (req, res) {

    let data = req.body;
    let picture_ref = '/public/img/' + data.word.toLowerCase() + '.jpg';

    //дописать проверку, что такой предмет уже есть и что поля не пустые

    let sql_insert = "INSERT INTO pictures (topic, word, picture_ref) VALUES (?, ?, ?)";
    pool.query(sql_insert, [data.topic, data.word, picture_ref], function (req1, res1) {});

    // The name of the input field (i.e. "sampleFile") is used to retrieve the uploaded file
    let sampleFile = req.files.picture;

    // Use the mv() method to place the file somewhere on your server
    let ref = '.' + picture_ref;
    sampleFile.mv(ref, function (err) {
        if (err)
            console.log(err);
    });

    console.log(data);

    res.render('main', {
        typeAuth: 'noLogin',
        type_content: 'admin'
    });

});

app.post('/register', urlencodedParser, function (req, res) {

    let data = req.body;

    console.log(data.login);

});

app.listen(3000);