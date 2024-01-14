const cartItem = document.querySelector(".cart-items-container")

const cartBtn = document.querySelector("#cart-btn");

cartBtn.addEventListener("click",function(){
    cartItem.classList.toggle("active");
    document.addEventListener("click",function(e){
        if (
            !e.composedPath().includes(cartBtn) &&
            !e.composedPath().includes(cartItem)
        ){
            searchForm.classList.remove("active");
        }

    });
});
// Düğmeye tıklandığında dropdown menüsünü kontrol et
document.getElementById("menuBtn").addEventListener("click", function() {
    var dropdownContent = document.getElementById("dropdownContent");
    // Eğer görünürse, gizle; değilse görünür yap
    dropdownContent.style.display = (dropdownContent.style.display === "block") ? "none" : "block";
});

// Sayfa herhangi bir yerine tıklanırsa dropdown menüsünü gizle
document.addEventListener("click", function(event) {
    var dropdownContent = document.getElementById("dropdownContent");
    if (event.target !== document.getElementById("menuBtn") && event.target.closest("#dropdownContent") !== dropdownContent) {
        dropdownContent.style.display = "none";
    }
});
