using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _regression_DDB148379_ddb148379_ddb148379_
    {
        [OuterLoop]
        [Fact]
        public void _regression_DDB148379_ddb148379_ddb148379_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\regression\\DDB148379\\ddb148379\\ddb148379.cmd");
        }
    }
}
