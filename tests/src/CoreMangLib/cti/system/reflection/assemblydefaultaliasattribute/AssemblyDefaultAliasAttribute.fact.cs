using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblydefaultaliasattribute_AssemblyDefaultAliasAttribute_AssemblyDefaultAliasAttribute_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblydefaultaliasattribute_AssemblyDefaultAliasAttribute_AssemblyDefaultAliasAttribute_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblydefaultaliasattribute\\AssemblyDefaultAliasAttribute\\AssemblyDefaultAliasAttribute.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
