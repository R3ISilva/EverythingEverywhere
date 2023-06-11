console.log('Patos Printer');   

function handleFileUpload(event) {
    var file = event.target.files[0];
    console.log("Uploaded file:", file);
    // Additional file handling logic here
  }

  function submitForms() {
    var selectElement1 = document.getElementById("answerSelect");
    var selectedOption1 = selectElement1.value;
    
    var selectElement2 = document.getElementById("answer2Select");
    var selectedOption2 = selectElement2.value;

    var answer3 = document.getElementById("answer3").value;
    var answer4 = document.getElementById("answer4").value;

    if (selectedOption1 && selectedOption2 && answer3 && answer4) {
      // Process the form submission
      console.log("Form submitted!");
      console.log("Selected Filament:", selectedOption1);
      console.log("Who Printed:", selectedOption2);
      console.log("Answer 3:", answer3);
      console.log("Answer 4:", answer4);
    } else {
      alert("Please fill in all the answers.");
    }
  }
      
      
function handleFileUpload(event) 
        var files = event.target.files;
        // Process the uploaded files
        console.log(files);

function handleFileUpload(event) 
        var files = event.target.files;
        // Process the uploaded files
        console.log(files);