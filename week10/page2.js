// $() -> jquery()

/*
$(document).ready(function(){

    $("p").hide();
   
});*/

$(function(){
    $("p").hide();
    $("p").show();
});

//tag selector
            //p  a  img  h1  body .... etc
//class selector
            //.intro .renkli .koyu ... etc
//id selector
            //#nav #content #menu ... etc
/*
            $("*") -> sayfadaki tüm elemanlar/etiketler
            $(this) -> geçerli eleman
            $("p.intro") -> class özelliği intro olan tüm p lerin listesi
            $("p:first") -> tüm p ler arasındaki ilk p etikleti
            $("ul li:first") -> tüm ul içerisindeki ilk li etiketleri
            $("ul li:first-child") -> tüm ul içerisindeki li içerisindeki ilk eleman
            $("[href]") -> köşeli parantez etiketin niteliği demektir. 
            $("a[target='_blank']")
            $("a[target!='_blank']")
            $(":button")
            $("tr:even") -> çift sıradaki satırlar
            $("tr:odd") ->tek sıradaki satırlar
            */
$(function(){
            $("ul li:first").css( {"background": "red"} );
            $("ul li:first-child").css( {"background": "yellow"} );
            $("[href]").css( {"background": "maroon"} );
            $("[target='_blank']").css( {"background": "green"} );

            $("tr:even").css( {"background": "#999"} );
            $("tr:odd").css( {"background": "#4a4a4a"} );
});

//same function can be written like below
//function getSumOfTwo (a,b){    return a+b;   }
var getSumOfTwo = function(a,b){    return a+b;    }

//events
        //click 
        //dblclick
        //mouseenter -> üzerine mouse gelirse çalışır
        //mouseleave -> mouse üzerinden ayrılırsa çalışıyor
        //mousedown
        //mouseup
        //hover -> mouse üzerine gelince çalışır
        //focus -> eleman seçili hale geldiğinde çalışıyor (örnek: metin kutusuna girince)
        //blur -> elemandan çıkıldığında (örnek: metin kutusunu terkedince)
        //on -> eventlar için genel bir metod

$(function(){
    //$("#boxDiv").mouseenter(); //deprecated
    $("#boxDiv").on({
        mouseenter: function(){
            $(this).addClass("selected");
        },
        mouseleave: function(){
            $(this).removeClass("selected");
        }
    })
});

$(document).on("click","td", function(){
    $(this).css({"text-align" : "right"});
});

$(function(){
    $("table tr").append($("<td>").text("new cell"));
});


//animation
        //$(selector).animate({params},speed,callback);

$(function(){
    $("#closeDiv").on("click", function(){
        closeDivAnimation();
    });
});

var closeDivAnimation = function (){
    $("#closeDiv span").animate({
        "top": "40px",
        "left": "40px"
    }, 5000, function(){
        $(this).text("O");
    });
}