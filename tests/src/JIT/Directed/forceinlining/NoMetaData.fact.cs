using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _forceinlining_NoMetaData_NoMetaData_
    {
        [OuterLoop]
        [Fact]
        public void _forceinlining_NoMetaData_NoMetaData_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\forceinlining\\NoMetaData\\NoMetaData.cmd");
        }
    }
}
