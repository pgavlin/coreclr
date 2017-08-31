using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblydescriptionattribute_AssemblyDescriptionAttributeCtor_AssemblyDescriptionAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblydescriptionattribute_AssemblyDescriptionAttributeCtor_AssemblyDescriptionAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblydescriptionattribute\\AssemblyDescriptionAttributeCtor\\AssemblyDescriptionAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
