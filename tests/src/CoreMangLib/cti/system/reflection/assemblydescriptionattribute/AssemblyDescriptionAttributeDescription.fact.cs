using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblydescriptionattribute_AssemblyDescriptionAttributeDescription_AssemblyDescriptionAttributeDescription_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblydescriptionattribute_AssemblyDescriptionAttributeDescription_AssemblyDescriptionAttributeDescription_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblydescriptionattribute\\AssemblyDescriptionAttributeDescription\\AssemblyDescriptionAttributeDescription.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
