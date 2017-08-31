using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_boolean_BooleanEquals_Object_BooleanEquals_Object_
    {
        [OuterLoop]
        [Fact]
        public void _system_boolean_BooleanEquals_Object_BooleanEquals_Object_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\boolean\\BooleanEquals_Object\\BooleanEquals_Object.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
