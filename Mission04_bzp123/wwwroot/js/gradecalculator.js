
//when users click the calculate button.
$("#btncalculate").click(function () {
    //getting the values from the form and weighing them
    var assignments = $("#Assignments").val() * .50;
    var groupproj = $("#GroupProject").val() * .10;
    var quiz = $("#Quiz").val() * .10;
    var midterm = $("#Midterm").val() * .10;
    var final = $("#Final").val() * .10;
    var intex = $("#INTEX").val() * .10;
    var grade;

    //summing the total numeric grade
    var total = assignments + groupproj + quiz + midterm + final + intex;

    //based on the numeric grade a letter grade is assigned.
    if (total > 94) {
        grade = 'A';
    } else if (90 <= total) {
        grade = 'A-';
    } else if (87 <= total) {
        grade = 'B+';
    } else if (84 <= total) {
        grade = 'B';
    } else if (80 <= total) {
        grade = 'B-';
    } else if (77 <= total) {
        grade = 'C+';
    } else if (74 <= total) {
        grade = 'C';
    } else if (70 <= total) {
        grade = 'C-';
    } else if (67 <= total) {
        grade = 'D+';
    } else if (64 <= total) {
        grade = 'D';
    } else if (60 <= total) {
        grade = 'D-';
    } else {
        grade = 'E';
    }

    //displays the letter grade in the div with the id of 'output' on the html page.
    //$('#output').append('Grade: ' + grade);
    alert('Grade: ' + grade)
})