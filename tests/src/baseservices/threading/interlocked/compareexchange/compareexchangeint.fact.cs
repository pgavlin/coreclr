using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_compareexchange_compareexchangeint_compareexchangeint_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_compareexchangeint_compareexchangeint_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\compareexchangeint\\compareexchangeint.cmd");
        }
    }
}
