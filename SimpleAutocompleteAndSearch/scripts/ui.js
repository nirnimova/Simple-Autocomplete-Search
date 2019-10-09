class UI {
    constructor($) {
        this.$ = $;
        this.jobAPI = new JobAPI;
        this.searchResults = document.getElementById('searchResults');
    }

    // Autocomplete
    autocomplete(inputTag) {
        $(`#${inputTag}`).autocomplete({
            source: (request, response) => {
                this.jobAPI.searchJobsTitle(request.term).then(res => {
                    response(res.jobTitles.Data);
                });
            }
        });
    }

    fillResults(jobs) { 
        let output = "";

        output += `<ul class="container">`;

        jobs.forEach((j) => output += `
            <li class="search card card-body">
                <h5 style="color:#2895f3;">${j.jobTitle}</h5>
                <div class="container">${j.jobDescription.substring(0,100)}...</div>
            </li>
        `);

        output += `</ul>`;

        this.searchResults.innerHTML = output;
    }

    clearResults() {
        this.searchResults.innerHTML = "";
    }
}