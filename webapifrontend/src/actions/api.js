import axios from "axios";

const baseUrl = "http://localhost:54658/api/"
// eslint-disable-next-line import/no-anonymous-default-export
export default {

    dCandidate(url = baseUrl + 'DCandidate/') {
        return {
            fetchAll: () => axios.get(url),
            fetchById: id => axios.get(url + id),
            create: newRecord => axios.post(url, newRecord),
            update: (id, updateRecord) => axios.put(url + id, updateRecord),
            delete: id => axios.delete(url + id)
        }
    }
}