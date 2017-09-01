using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_ldargs_stargs_ldargs_stargs_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ldargs_stargs_ldargs_stargs_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ldargs_stargs\\ldargs_stargs.cmd");
        }
    }
}
