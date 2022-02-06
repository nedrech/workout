var args = process.argv.slice(2);

var shortest = args.sort((a,b) => a.length - b.length)[0];
var len = shortest?.length;

var arr = [];
for(var i = 0; i < len; i++)
for(var j = i + 1; j <= len; j++) {
    var match = true;
    var fragment = shortest.slice(i,j);
    
    for(var w of args)
        if(!w.includes(fragment)) match = false;

    if(match) arr.push(fragment);
}

console.log(arr.reduce((a,b) => a.length > b.length ? a : b, ''));