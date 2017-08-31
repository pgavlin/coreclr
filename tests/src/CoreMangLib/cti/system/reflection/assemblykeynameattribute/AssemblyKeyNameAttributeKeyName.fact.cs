using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblykeynameattribute_AssemblyKeyNameAttributeKeyName_AssemblyKeyNameAttributeKeyName_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblykeynameattribute_AssemblyKeyNameAttributeKeyName_AssemblyKeyNameAttributeKeyName_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblykeynameattribute\\AssemblyKeyNameAttributeKeyName\\AssemblyKeyNameAttributeKeyName.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
