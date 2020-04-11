namespace WageLib
{
    public interface IWage
    {
        #region Properties

        /// <summary>
        /// ...
        /// </summary>
        double Salary { get; set; }

        /// <summary>
        /// ....
        /// </summary>
        int Shifts { get; set; }
        #endregion

        #region Methods
        double CalculateWage();
        #endregion
    }
}
