using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblydelaysignattribute_AssemblyDelaySignAttributeCtor_AssemblyDelaySignAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblydelaysignattribute_AssemblyDelaySignAttributeCtor_AssemblyDelaySignAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblydelaysignattribute\\AssemblyDelaySignAttributeCtor\\AssemblyDelaySignAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
