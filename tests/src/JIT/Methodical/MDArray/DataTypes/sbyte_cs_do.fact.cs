using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_DataTypes_sbyte_cs_do_sbyte_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_DataTypes_sbyte_cs_do_sbyte_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\DataTypes\\sbyte_cs_do\\sbyte_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
