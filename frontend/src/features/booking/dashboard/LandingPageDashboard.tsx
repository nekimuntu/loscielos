import { Grid } from "semantic-ui-react";
import CabinsList from "./CabinsList";
import FormBooking from "./FormBooking";
import HeaderLogoIcon from "./Header";
import ImageHeader from "./ImageHeader";
import Footer from "../../../app/layout/footer";

function LandingPageDashboard(){
    return(
        <>
        <HeaderLogoIcon />
        <FormBooking />
        <ImageHeader />
        <Grid>
            <Grid.Column width={2}></Grid.Column>
            <Grid.Column width={12}>
            <CabinsList/>
            </Grid.Column>
            <Grid.Column width={2}></Grid.Column>
        </Grid>
        <Footer />
        </>
    );
}
export default LandingPageDashboard;