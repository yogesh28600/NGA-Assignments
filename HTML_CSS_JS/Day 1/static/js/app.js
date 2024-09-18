(() => {
  'use strict'
  const forms = document.querySelectorAll('.needs-validation')
  Array.from(forms).forEach(form => {
    form.addEventListener('submit', event => {
      if (!form.checkValidity()) {
        event.preventDefault()
        event.stopPropagation()
      }

      form.classList.add('was-validated')
    }, false)
  })
})()

function getErrors(){
  var fname = document.getElementById("firstname").value;
  var lname = document.getElementById("lastname").value;
  var mname = document.getElementById("middlename").value
  var country = document.getElementById("country").value;
  var dob = document.getElementById("dob").value;
  var age = document.getElementById("age").value;
  var errors = []
  if(fname == ""){
    errors.push("Enter First Name")
  }
  if(mname == ""){
    errors.push("Enter Last Name")
  }
  if(lname == ""){
    errors.push("Enter Last Name")
  }
  if(country == ""){
    errors.push("Select Country")
  }
  if(dob == "")
    errors.push("Enter DOB")
  if(age < 1)
    errors.push("Enter Age")
  return errors
}
function addEmployee(){
  var fname = document.getElementById("firstname").value;
  var lname = document.getElementById("lastname").value;
  var mname = document.getElementById("middlename").value
  var country = document.getElementById("country").value;
  var dob = document.getElementById("dob").value;
  var age = document.getElementById("age").value;
  var male = document.getElementById("Male").value;
  var isExperienced = document.getElementById("isExperienced").value;
  var experience = document.getElementById("Experience").value
  var errors = getErrors()
  console.log(errors)
  if(errors.length != 0){
    var element = document.getElementById("eList")
    var errorH6 = document.getElementById('ErrorHeading')
    errorH6.classList.remove('invisible')
    errorH6.classList.add("error")
    element.classList.remove("invisible")
    element.classList.add("error")
    for(var error of errors){
      var li = document.createElement('li')
      li.innerHTML = error
      element.appendChild(li)
    }
    return
  }
  var gender = male? "Male":"Female";
  var message = "First Name: "+ fname + "\n" +"Middle Name: " + mname+"\n" + "Last Name: "+lname+"\n" +"Age: "+age+"\n"+"Gender: "+gender+"\n"+ "Country: "+ country + "\n"+"Date of Birth: "+ dob+"\n"+"Is Experienced: "+ isExperienced+"\n"+"Experience: "+experience
  alert(message)

}

function getData(){
  var xhr = new XMLHttpRequest()
  var url = "https://freetestapi.com/api/v1/products"
  xhr.open("GET",url)
  xhr.onreadystatechange = function() {
    if(this.status == 200){
      const products = JSON.parse(this.responseText)
      var productstable = document.getElementById("productsTable")
      for(var product of products){
        var row = document.createElement('tr')
        var id = document.createElement('td')
        var name = document.createElement('td')
        var price = document.createElement('td')
        id.innerHTML = product.id
        name.innerHTML = product.name
        price.innerHTML = product.price
        row.appendChild(id)
        row.appendChild(name)
        row.appendChild(price)
        productstable.appendChild(row)
      }
    }
  }
  xhr.send()
}

