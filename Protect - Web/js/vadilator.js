function Validator (options){

    var selectorRules = {};

    function Vadilate(inputElement,rule){

        var errorElement= inputElement.parentElement.querySelector(options.errorSelector);
        var errorMessage=rule.test(inputElement.value);
        var rules = selectorRules[rule.selector];

        for(var i = 0; i< rules.length; ++i) {
            errorMessage = rules[i] (inputElement.value);
            if(errorMessage) break;
        }
        if(errorMessage){

            errorElement.innerText = errorMessage;
            inputElement.parentElement.classList.add('invalid');          
        }
        else{   

            errorElement.innerText = '';
            inputElement.parentElement.classList.remove('invalid');
        }
    }



    var formElement =document.querySelector(options.form);

    if(formElement){

        formElement.onsubmit= function(e){
            e.parentElement();

            options.rules.forEach(function(rule){
                var inputElement=formElement.querySelector(rule.selector);
                Vadilate(inputElement,rule);
            });
        }

        options.rules.forEach(function(rule){

            
            if(Array.isArray(selectorRules[rule.selector])) {
                selectorRules[rule.selector].push(rule.test);
            }else{
                selectorRules[rule.selector] = [rule.test];
            }

            var inputElement=formElement.querySelector(rule.selector);

            if(inputElement){
                
                inputElement.onblur=function(){

                    Vadilate(inputElement,rule);
                }
            }
                inputElement.oninput = function(){

                    var errorElement= inputElement.parentElement.querySelector(options.errorSelector);

                    errorElement.innerText = '';
                    inputElement.parentElement.classList.remove('invalid');
                }
        })
    }
}



Validator.isRequired = function (selector,message){

    return {
        selector:selector,
        test:function(value){
            
            return value.trim() ? undefined : message||'Vui lòng nhập trường này.';
        }
    }
}

Validator.isEmail = function (selector,message){

    return {
        selector:selector,
        test:function(value){
            
            var regex= /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;

            return regex.test(value) ? undefined : message || 'Trường này không phải là email.';
        }
    }
}

Validator.minLength = function (selector,min,message){

    return {
        selector:selector,
        test:function(value){

            return value.length >= min ? undefined : message || `Vui lòng nhập tối thiểu ${min} kí tự`;
        }
    }
}

Validator.isComfirmed = function (selector,getConfirmValue, message){

    return {
        selector: selector,
        test: function(value){

            return value === getConfirmValue() ? undefined : message || 'Giá trị nhập vào không trùng khớp.';
        }
    }
}
