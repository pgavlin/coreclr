using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _JitBlue_DevDiv_1206929_DevDiv_1206929_DevDiv_1206929_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_1206929_DevDiv_1206929_DevDiv_1206929_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_1206929\\DevDiv_1206929\\DevDiv_1206929.cmd");
        }
    }
}
