using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_directed_AutoInit_AutoInit_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_AutoInit_AutoInit_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\AutoInit\\AutoInit.cmd");
        }
    }
}
