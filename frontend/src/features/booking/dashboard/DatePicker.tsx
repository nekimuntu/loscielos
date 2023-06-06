import { useState } from "react";
import ReactDatePicker from "react-datepicker";
import { Grid } from "semantic-ui-react";


const DatePicker = () => {
    const [startDate, setStartDate] = useState(new Date(Date.now()));
    const [endDate, setEndDate] = useState(new Date(Date.now()));
    return (
        <>
            <Grid columns={2} divided>
                <Grid.Row>
                    <Grid.Column>
                        <ReactDatePicker
                            selected={startDate}
                            onChange={(date:Date) => setStartDate(date)}
                            selectsStart
                            startDate={startDate}
                            endDate={endDate}
                            dateFormat="dd/MM/yyyy"
                        />
                    </Grid.Column>
                    <Grid.Column>
                        <ReactDatePicker
                            selected={endDate}
                            onChange={(date:Date) => setEndDate(date)}
                            selectsEnd
                            startDate={startDate}
                            endDate={endDate}
                            minDate={startDate}
                            dateFormat="dd/MM/yyyy"
                        />
                    </Grid.Column>
                </Grid.Row>
            </Grid>
        </>
    );
};

export default DatePicker;