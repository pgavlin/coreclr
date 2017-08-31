using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblytitleattribute_AssemblyTitleAttributeCtor_AssemblyTitleAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblytitleattribute_AssemblyTitleAttributeCtor_AssemblyTitleAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblytitleattribute\\AssemblyTitleAttributeCtor\\AssemblyTitleAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
