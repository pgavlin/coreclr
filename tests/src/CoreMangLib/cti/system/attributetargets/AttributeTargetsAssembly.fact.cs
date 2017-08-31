using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsAssembly_AttributeTargetsAssembly_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsAssembly_AttributeTargetsAssembly_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsAssembly\\AttributeTargetsAssembly.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
