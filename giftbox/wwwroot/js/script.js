document.getElementById('openGiftBtn').addEventListener('click', function () {
    const giftBox = document.getElementById('giftBox');
    const lid = giftBox.querySelector('.lid');
    const boxContent = giftBox.querySelector('.box-content');
    const giftMessage = document.getElementById('giftMessage');
    const winnerName = document.getElementById('winnerName');

    // Animate the lid opening
    lid.style.transform = 'rotateX(-120deg)';

    // Fetch random employee from the backend after a short delay to simulate the animation
    setTimeout(function () {
        fetch('/Home/Lottery')  // Call the backend endpoint to get a random employee
            .then(response => response.json())
            .then(employee => {
                // Display the winner's name after the animation
                winnerName.textContent = `Congratulations, ${employee.name}!`;
                boxContent.style.opacity = '1';
                giftMessage.style.visibility = 'visible';
            })
            .catch(error => {
                console.error('Error fetching random employee:', error);
            });
    }, 1000); // Wait for the lid animation to finish before showing the employee

});
