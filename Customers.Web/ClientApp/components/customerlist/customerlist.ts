import Vue from 'vue';
import { Component } from 'vue-property-decorator';

interface Error {
    title: string;
    errorMessage: string;
}

interface Response {
    data: object;
    errors: Error[];
}

interface Customer {
    id: number;
    firstName: string;
    lastName: string;
    street: string;
    city: string;
    country: string;
    customerStatus: number;
}

@Component
export default class CustomerListComponent extends Vue {
    customerList: Customer[] = [];

    mounted() {
        fetch('api/customer/all')
            .then(response => response.json() as Promise<Customer[]>)
            .then(data => {
                this.customerList = data;
            });
    }
}
