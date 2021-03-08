function vote() {
    var age, canVote;
    age = document.getElementById('age').value;
    canVote = (age > 18) ? "You are old enough": "Sorry, you are not old enough";
    document.getElementById('eligible').innerHTML = canVote + " to vote.";
}