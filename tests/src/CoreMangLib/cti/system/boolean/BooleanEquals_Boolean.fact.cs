using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_boolean_BooleanEquals_Boolean_BooleanEquals_Boolean_
    {
        [OuterLoop]
        [Fact]
        public void _system_boolean_BooleanEquals_Boolean_BooleanEquals_Boolean_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\boolean\\BooleanEquals_Boolean\\BooleanEquals_Boolean.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
