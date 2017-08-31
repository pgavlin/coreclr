using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblykeynameattribute_AssemblyKeyNameAttributeCtor_AssemblyKeyNameAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblykeynameattribute_AssemblyKeyNameAttributeCtor_AssemblyKeyNameAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblykeynameattribute\\AssemblyKeyNameAttributeCtor\\AssemblyKeyNameAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
