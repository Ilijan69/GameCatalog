document.getElementById('searchInput').addEventListener('input', function () {
    const query = this.value;

    fetch(`/Game/Search?searchQuery=${query}`)
        .then(response => response.text())
        .then(html => {
            document.getElementById('gameList').innerHTML = html;
        })
        .catch(error => console.error('Error:', error));
});