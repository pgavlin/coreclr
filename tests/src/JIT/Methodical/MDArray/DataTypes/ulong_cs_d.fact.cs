using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_DataTypes_ulong_cs_d_ulong_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_DataTypes_ulong_cs_d_ulong_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\DataTypes\\ulong_cs_d\\ulong_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
