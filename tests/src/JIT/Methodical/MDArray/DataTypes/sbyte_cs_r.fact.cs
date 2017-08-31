using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_DataTypes_sbyte_cs_r_sbyte_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_DataTypes_sbyte_cs_r_sbyte_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\DataTypes\\sbyte_cs_r\\sbyte_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
