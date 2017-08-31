using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_boolean_BooleanCompareTo_Boolean_BooleanCompareTo_Boolean_
    {
        [OuterLoop]
        [Fact]
        public void _system_boolean_BooleanCompareTo_Boolean_BooleanCompareTo_Boolean_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\boolean\\BooleanCompareTo_Boolean\\BooleanCompareTo_Boolean.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
