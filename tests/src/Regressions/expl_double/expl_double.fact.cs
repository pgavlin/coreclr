using CoreclrTestLib;
using Xunit;

namespace Regressions_expl_double
{
    public class _expl_double_expl_double_
    {
        [OuterLoop]
        [Fact]
        public void _expl_double_expl_double_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\expl_double\\expl_double\\expl_double.cmd");
        }
    }
}
