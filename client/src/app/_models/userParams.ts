import { User } from "./user";

export class UserParams {
    gender: string | 'all';
    minAge = 16;
    maxAge = 99;
    pageNumber = 1;
    pageSize = 5;
    orderBy = 'lastActive';

    constructor(user: User){
        this.gender = user.gender === 'female' ? 'male' : 'female';
        // this.gender = user.gender === 'female' ? 'male' : user.gender === ('male' && 'female') ? 'male' : 'all';
        //this.gender = user.gender === 'female' ? 'male' : user.gender === 'male' ? 'female' : user.gender === 'male' && 'female' ? 'all' : 'all';
    }
}