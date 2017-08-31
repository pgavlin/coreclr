using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_DataTypes_decimal_cs_do_decimal_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_DataTypes_decimal_cs_do_decimal_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\DataTypes\\decimal_cs_do\\decimal_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
