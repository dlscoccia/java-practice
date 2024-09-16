const express = require('express');
const cors = require('cors');
require('dotenv').config();

const { dbConection } = require('./database/config');

const app = express();

app.use(cors());

dbConection();

app.get('/', (req, res) => {
    res.json({
        ok: true,
        msg: 'hello Fonzi',
    });
});

const PORT = process.env.PORT || 3000;
app.listen(PORT, () => {
    console.log(`Server running on port: ${PORT}`);
});

// root_mean
// KOt8r68tCUnJzmHG
