using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_DataTypes_ushort_cs_do_ushort_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_DataTypes_ushort_cs_do_ushort_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\DataTypes\\ushort_cs_do\\ushort_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
