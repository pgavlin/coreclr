using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_DataTypes_ulong_cs_do_ulong_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_DataTypes_ulong_cs_do_ulong_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\DataTypes\\ulong_cs_do\\ulong_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
