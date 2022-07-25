function selectedImage() {
    const inputFile = document.createElement("input")
    inputFile.type = "file"
    inputFile.accept = "image/*"
    inputFile.click();

    inputFile.addEventListener('change', changeEvent => {
        const reader = new FileReader()
        reader.onload = (loadEvent) => {
            const base64Text = loadEvent.currentTarget.result
            console.log("modifyImage.js : " + base64Text)
            return base64Text
        }
        reader.readAsDataURL(changeEvent.target.files[0])
    })
}