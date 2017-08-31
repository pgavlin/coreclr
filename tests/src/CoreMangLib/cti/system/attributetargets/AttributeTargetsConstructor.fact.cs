using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsConstructor_AttributeTargetsConstructor_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsConstructor_AttributeTargetsConstructor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsConstructor\\AttributeTargetsConstructor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
