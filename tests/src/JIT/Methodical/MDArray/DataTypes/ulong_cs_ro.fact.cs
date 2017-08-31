using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_DataTypes_ulong_cs_ro_ulong_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_DataTypes_ulong_cs_ro_ulong_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\DataTypes\\ulong_cs_ro\\ulong_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
