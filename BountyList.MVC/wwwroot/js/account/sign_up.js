function submit() {
    let [validated, errMsg] = validate();
    if (validated) {
        submitAjax();
    }
    else {
        alert(errMsg);
    }
}

function validate() {
    return [true, ''];
}

function submitAjax() {
    axios.post("SignUp", {}, {
        params: {
            email: 'javascriptBasics@gmail.com',
            password: '1234'
        }
    })
    .then((response) => console.log(response))
    .catch((error) => console.log(error))
}