import { Fragment } from "react";
import { Header } from "semantic-ui-react";
import CabinsListItem from "./CabinsListItem";

function CabinsList(){

    return(

        <>
        <Fragment>
            <Header sub color='teal' />
            <CabinsListItem />
        </Fragment>
        </>
    );

}
export default CabinsList;