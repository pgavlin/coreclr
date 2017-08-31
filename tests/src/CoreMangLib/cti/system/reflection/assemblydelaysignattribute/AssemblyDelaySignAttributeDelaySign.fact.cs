using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblydelaysignattribute_AssemblyDelaySignAttributeDelaySign_AssemblyDelaySignAttributeDelaySign_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblydelaysignattribute_AssemblyDelaySignAttributeDelaySign_AssemblyDelaySignAttributeDelaySign_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblydelaysignattribute\\AssemblyDelaySignAttributeDelaySign\\AssemblyDelaySignAttributeDelaySign.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
