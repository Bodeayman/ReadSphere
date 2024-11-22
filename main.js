document.addEventListener('DOMContentLoaded', () => {
    // Initialize reading challenge data
    const challengeData = {
        goal: 5,
        completed: 0,
        behind: 4
    };

    // Update progress bar
    function updateProgress() {
        const percentage = (challengeData.completed / challengeData.goal) * 100;
        document.querySelector('.progress').style.width = `${percentage}%`;
        document.querySelector('.stats h2').textContent = challengeData.completed;
        document.querySelector('.percentage').textContent =
            `${challengeData.completed}/${challengeData.goal} (${percentage}%)`;
    }

    // Search functionality
    const searchInputs = document.querySelectorAll('input[type="search"]');
    searchInputs.forEach(input => {
        input.addEventListener('keypress', (e) => {
            if (e.key === 'Enter') {
                alert('Search functionality would go here!');
            }
        });
    });

    // Vote button interaction
    const voteBtn = document.querySelector('.vote-btn');
    voteBtn.addEventListener('click', () => {
        alert('Voting functionality would go here!');
    });

    // Initialize the progress
    updateProgress();
});