export const CustomDropdown = (props) => (
    <div class="container">
        <div class="row">
            <div class="col-sm">
                {props.title}
            </div>
            <div class="col-sm">
                <select
                    className="form-select"
                    name="{props.key}"
                    onChange={props.onChange}
                >
                    <option defaultValue>Select {props.key}</option>
                    {props.options.map((item, index) => (
                        <option key={index} value={item.id}>
                            {item.key}
                        </option>
                    ))}
                </select>
            </div>
        </div>
    </div>
)