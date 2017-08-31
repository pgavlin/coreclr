using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblytitleattribute_AssemblyTitleAttributeTitle_AssemblyTitleAttributeTitle_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblytitleattribute_AssemblyTitleAttributeTitle_AssemblyTitleAttributeTitle_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblytitleattribute\\AssemblyTitleAttributeTitle\\AssemblyTitleAttributeTitle.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
