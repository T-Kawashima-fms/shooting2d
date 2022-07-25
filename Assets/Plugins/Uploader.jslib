mergeInto(LibraryManager.library, {
    getImage: function () {
        console.log("Uploder.jslib : " + selectedImage());
        return selectedImage();
    },
});