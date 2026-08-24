const http = require("http");
const fs = require("fs");
const path = require("path");

const port = process.env.PORT || 8080;

const server = http.createServer((req, res) => {
    let file = req.url === "/" ? "/index.html" : req.url;

    const filePath = path.join(__dirname, file);

    fs.readFile(filePath, (error, content) => {
        if (error) {
            res.writeHead(404);
            res.end("File not found");
            return;
        }

        const extension = path.extname(filePath);

        const contentTypes = {
            ".html": "text/html",
            ".css": "text/css",
            ".js": "text/javascript"
        };

        res.writeHead(200, {
            "Content-Type": contentTypes[extension] || "text/plain"
        });

        res.end(content);
    });
});

server.listen(port, () => {
    console.log(`Server running on port ${port}`);
});