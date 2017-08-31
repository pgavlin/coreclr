using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_DataTypes_ushort_cs_r_ushort_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_DataTypes_ushort_cs_r_ushort_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\DataTypes\\ushort_cs_r\\ushort_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
