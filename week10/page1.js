//alert("JS is working");
console.time("timer1");

var length = 16;
var fullname = "Zahid Gürbüz"   ;
var student = {  //object
    number: 2024111111,
    fullname: "Doruk Mete",
    department: "Computer Engineering"
};

console.log(length, fullname);
console.log({length, fullname, student, number: student.number});

//empty array
var emptyArray = []; 

//array of string
var fruits = ["apple", "orange", "banana"];
console.log({fruits});

//array of objects
var studentList = [
    {  //object
        number: 2024111111,
        fullname: "Doruk Mete",
        department: "Computer Engineering"
    },
    {  //object
        number: 2024222222,
        fullname: "Kerem Batu",
        department: "Computer Engineering"
    },
    {  //object
        number: 2024333333,
        fullname: "Mehmet Emir",
        department: "Computer Engineering"
    }
];

console.log({studentList, student1: studentList[1], "fullname": studentList[1].fullname});

console.timeEnd("timer1");

//functions
function functionName(parameter1, parameter2){
    //your function code
    //return 0;
}


//get the maximum of two numbers
function getMax(num1, num2){
    if(num1 > num2)
        return num1;
    return num2;
}

//second way
var getMax2 = function(num1, num2) {
    if(num1 > num2)
        return num1;
    return num2;
};

//thirdway: lambda function
var getMax3 = (num1, num2) => ((num1>num2) ? num1: num2);


var maxOfTwoNumbers = getMax(5,8);
var maxOfTwoNumbers2 = getMax2(5,8);
var maxOfTwoNumbers3 = getMax3(5,8);

console.log({maxOfTwoNumbers, maxOfTwoNumbers2,maxOfTwoNumbers3});

console.assert(getMax(3, 5) === 5, "Failed: getMax(3, 5)");
console.assert(getMax(-1, 7) === 7, "Failed: getMax(-1, 7)");
console.assert(getMax(10, 10) === 10, "Failed: getMax(10, 10)");
console.assert(getMax(-5, -2) === -2, "Failed: getMax(-5, -2)");
console.assert(getMax(0, 0) === 0, "Failed: getMax(0, 0)");
console.assert(getMax(100, 50) === 100, "Failed: getMax(100, 50)");

//String Functions
//+ -> concatenation 
//length -> returns the character count of the string
//indexOf -> finds the location of a string inside the string.
//lastIndexOf -> finds the location of a string inside the string. in reverse order
//slice(start, end) -> gets a partition of string. 
//substring(start, end) -> similar to slice. but no negative values.
//substr(start, length) -> similar to slice. bu second parameter is length

var message = "Today, weather is very good. Hello " + fullname;

console.log(message);
console.log(message.length);
console.log(message.indexOf("weather"));
console.log(message.indexOf("a"));
console.log(message.indexOf("a", 4));
console.log(message.indexOf("bee"));

function getCount(message, searchKey){
    if(message == "" || searchKey == "")
        return 0;

    var position = 0; 
    var numOfItems = 0; 
    position = message.indexOf(searchKey);
    while(position != -1) {
        numOfItems ++;
        position = message.indexOf(searchKey, position+1);
    }
    return numOfItems;
}

console.assert(getCount("hello world", "o") === 2, "Failed: getCount('hello world', 'o')");
console.assert(getCount("banana", "a") === 3, "Failed: getCount('banana', 'a')");
console.assert(getCount("apple", "p") === 2, "Failed: getCount('apple', 'p')");
console.assert(getCount("mississippi", "iss") === 2, "Failed: getCount('mississippi', 'iss')");
console.assert(getCount("aaaaa", "aa") === 4, "Failed: getCount('aaaaa', 'aa')");
console.assert(getCount("", "x") === 0, "Failed: getCount('', 'x')");
console.assert(getCount("hello", "") === 0, "Failed: getCount('hello', '')");
console.assert(getCount("hello", "z") === 0, "Failed: getCount('hello', 'z')");
console.assert(getCount("hello", null) === 0, "Failed: getCount('hello', null)");


console.log(message.slice(7,14));
console.log(message.slice(-12,-7));
console.log(message.substring(7,14));
console.log(message.substring(-12,-7)); //error
console.log(message.substr(7,7));



//Arrays
var fruits = ["apple", "orange", "banana"];
var numbers = [5,8,2,1,9];

//join: array elemanlarını bir ayraç ile birleştirir
//pop: array in son elemanını çıkartır
//push: array sonuna bir eleman ekler
//shift: pop a benzer. arrayin ilk elemanını çıkartır
//unshift: push a benzer. arrayin ilk elemanına ekleme yapar
//delete: farklı çalışır. herhangi bir elemanın için siler. diziden çıkartmaz
//splice: array e istediğiniz index e eleman ekleme/çıkartma yapar
//concat: birden fazla array i birleştirir. 
//slice: array in bir parçasını alır. başka bir array yapar.
//sort: diziyi sıralar
//[...array] -> clone the array

console.log(fruits.join());
console.log(fruits.join("->"));
fruits.push("Grape","Melon","Water melon");
console.log({fruits});
var waterMelon = fruits.pop();
console.log({waterMelon, fruits});
fruits.unshift("Kiwi");
console.log({"unshift":[...fruits]}); //clone of the array
fruits.shift();
console.log({"shift":fruits});
fruits.splice(2,0, "lemon");
console.log({"splice1":[...fruits]});
fruits.splice(2,1);
console.log({"splice2":[...fruits]});
console.log({"slice":fruits.slice(2,3)});
console.log({"slice":fruits.slice(2,5)});

//concat
var boys = ["ali","veli", "deniz"];
var girls = ["ayse", "fatma", "hayriye","deniz"];
console.log({boys, girls, "concat":boys.concat(girls)});

fruits.sort();
console.log({"sort1":[...fruits]});

numbers.sort(function (a,b){
    return a-b;
});
console.log({"sort2":[...numbers]});

numbers.sort(function (a,b){
    return b-a;
});
console.log({"sort3":[...numbers]});

numbers.sort(function (a,b){
    return 0.5-Math.random(); //random order
});
console.log({"sort4":[...numbers]});

//random numbers
console.log( Math.random() ); // random [0-1] decimal numbers
console.log( Math.random() *10 ); // random [0-10] decimal numbers
console.log( parseInt( Math.random() *10 ) ); //random [0-10] integer
console.log( parseInt( 5 + Math.random() *10 ) ); //random [5-15] integer

//dates
//new Date()
//new Date(year, month, day, hours, minutes, seconds, milliseconds)
//new Date(milliseconds)
//new Date(date string)

var today = new Date(); 
console.log({today});
console.log({"a date": new Date("Fri Apr 21 2023 10:10:54 GMT+0300")});
console.log({"tiny mistake date": new Date("Wed Apr 21 2023 10:10:54 GMT+0300")}); //21 april is not wednesday
console.log({"completely wrong date": new Date("not a date")});  //Invalid Date


console.log("toString: ",today.toString());
console.log("toDateString: ",today.toDateString());
console.log("toTimeString: ",today.toTimeString());
console.log("toISOString: ",today.toISOString());
console.log("toUTCString: ",today.toUTCString());
console.log("toLocaleDateString: ",today.toLocaleDateString());
console.log("toLocaleTimeString: ",today.toLocaleTimeString());
console.log("toJSON: ",today.toJSON());
console.log("getMilliseconds: ",today.getMilliseconds());
console.log("getFullYear: ",today.getFullYear());

