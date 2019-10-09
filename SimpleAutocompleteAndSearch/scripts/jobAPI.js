class JobAPI {
    constructor() {
        this.autocomplete_count = 5;
        this.result_count = 10;
    }

    async searchJobsTitle(str) {
        const data = await fetch(`/api/jobs/SearchJobsTitle?str=${str}&count=${this.autocomplete_count}`);
        const jobTitles = await data.json();

        return {
            jobTitles
        }
    }

    async searchJobsByTitle(title) {
        const data = await fetch(`/api/jobs/SearchJobsByTitle?title=${title}&count=${this.result_count}`);
        const jobs = await data.json();

        return {
            jobs
        }
    }
}