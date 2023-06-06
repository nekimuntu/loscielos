import { Formik } from "formik";
import { observer } from "mobx-react-lite";
import { Button,Form, Segment, Header, Grid, Label } from "semantic-ui-react";
import { BookingDto } from "../../../app/model/BookingDto";
import { useState } from "react";
import MyDateArea from "../../../common/form/MyDateInput";
import MyTextInput from "../../../common/form/MyTextInput";
import MyDateInput from "../../../common/form/MyDateInput";

function FormBooking() {
    const [startDate, setStart] = useState(new Date(Date.now()))
    const [endDate, setEnd] = useState(new Date())

    const [stateBooking, setBooking] = useState<BookingDto>(
        {
            checkin: "",
            checkout: "",
            nbPerson: 0,
            nbBed: 0,
        }
    );
    const handleFormSubmit = (values: BookingDto) => {
        //Check des dates de dispo des cabines 
        console.log(values);
    }
    const openModal = () => { }

    return (
        <Segment sub >
            <Header textAlign="center" content="Book your dream" color="teal" />
            <Formik
                initialValues={stateBooking}
                onSubmit={(values) => handleFormSubmit(values)}
            >
                {({ handleSubmit, isValid, isSubmitting, dirty }) => (
                    <Form
                        className="ui form"
                        onSubmit={handleSubmit}
                        autoComplete='off'
                    >
                        <Grid centered={true} textAlign={"center"}>
                            <Grid.Column width={2}>
                                <Label content="Checkin" />
                                <MyDateInput
                                    selected={startDate}
                                    startDate={startDate}
                                    selectsStart
                                    placeholderText="Checkin"
                                    name='checkin'
                                    dateFormat='MM dd yyyy'
                                    onChange={(date: Date) => setStart(date)}
                                />
                            </Grid.Column>
                            <Grid.Column width={2} >
                                <Label content="Checkin" />
                                <MyDateInput
                                    selected={endDate}
                                    selectsEnd
                                    startDate={startDate}
                                    minDate={startDate}
                                    endDate={endDate}
                                    placeholderText="Checkout"
                                    name='checkout'
                                    dateFormat='MM dd yyyy'
                                    onChange={(date: Date) => setEnd(date)}
                                />
                            </Grid.Column>
                            <Grid.Column width={2}>
                                <Grid.Row>
                                    <Grid.Column width={2}>
                                        <Label content={"Nb Persons"} visible={false} />
                                    </Grid.Column>
                                </Grid.Row>
                                <Grid.Row width={1}>
                                    <Grid.Column width={1}>
                                        <MyTextInput name="nbRoom" placeholder=" Nb Persons" />
                                        <MyTextInput name="nbRoom" placeholder=" Nb Rooms" />
                                    </Grid.Column>
                                </Grid.Row>
                            </Grid.Column>                            
                                    <Grid.Column width={1} divided="vertically">
                                        <Label content="" />
                                        <Button
                                            floated="right"
                                            positive type="submit" content="Booking"
                                        />
                                    </Grid.Column>
                                
                            
                        </Grid>
                    </Form>

                )}
            </Formik>
        </Segment>
    );
}
export default observer(FormBooking);
