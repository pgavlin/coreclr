using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_DataTypes_sbyte_cs_ro_sbyte_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_DataTypes_sbyte_cs_ro_sbyte_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\DataTypes\\sbyte_cs_ro\\sbyte_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
