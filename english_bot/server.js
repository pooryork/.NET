const express = require('express');
const ejs = require('ejs');
let bodyParser = require("body-parser");
let urlencodedParser = bodyParser.urlencoded({
    extended: false
});
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

app.use(express.static(__dirname + "/public"));
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
                data: res1,
                emails: ["gavgav@mycorp.com", "mioaw@mycorp.com"]
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
    pool.query(sql, ['animals'], function (req, res) {

        console.log(res);
        let words = new Array();
        let refs = new Array();
        let topics = new Array();

        for (i in res) {
            //console.log(i);
            words.push(res[i].word);
            topics.push(res[i].topic);
            refs.push(res[i].picture_ref);
            // console.log(res[i].word);
            // console.log(res[i].topic);
            // console.log(res[i].picture_ref);
        }
        console.log(words);
        console.log(topics);
        console.log(refs);

    });
    res.render('main', {
        typeAuth: 'noLogin',
        type_content: 'train'
    });
});

app.get('/admin', function (req, res) {
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